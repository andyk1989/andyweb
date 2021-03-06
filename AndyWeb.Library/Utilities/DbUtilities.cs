﻿using EntityFramework.BulkInsert.Extensions;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AndyWeb.Library.Utilities
{
    public static class DbUtilities
    {
        private const int TRANSACTION_ENTITY_COUNT_LIMIT = 1000;

        public static void BulkInsert<DB, T>(IEnumerable<T> entityCollection)
            where DB: DbContext, new()
            where T: class
        {
            DB context = new DB();
            context.BulkInsert(entityCollection, TRANSACTION_ENTITY_COUNT_LIMIT);
        }

        public static void BulkInsertAndThrowaway<DB, T>(List<T> entityList)
            where DB : DbContext, new()
            where T : class
        {
            DB context = new DB();
            while(entityList.Any())
            {
                int countAmount = TRANSACTION_ENTITY_COUNT_LIMIT;
                if(entityList.Count < TRANSACTION_ENTITY_COUNT_LIMIT)
                {
                    countAmount = entityList.Count;
                }

                context.BulkInsert(entityList.GetRange(0, countAmount), TRANSACTION_ENTITY_COUNT_LIMIT);
                entityList.RemoveRange(0, countAmount);
            }
        }

        public static void IncrementalInsert<DB, T>(IEnumerable<T> entityCollection)
            where DB : DbContext, new()
            where T : class
        {
            DB context = null;
            try
            {
                context = new DB();
                context.Configuration.ValidateOnSaveEnabled = false;
                context.Configuration.AutoDetectChangesEnabled = false;

                int runningCount = 0;
                foreach (var entityToInsert in entityCollection)
                {
                    runningCount++;
                    context = AddToContext(context, entityToInsert, runningCount, TRANSACTION_ENTITY_COUNT_LIMIT, true);
                }

                context.SaveChanges();
            }
            finally
            {
                if (context != null)
                {
                    context.Dispose();
                }
            }
        }

        public static DB AddToContext<DB, T>(this DB context, T entity, int runningCount, int commitCountLimit, bool recreateContext)
            where DB : DbContext, new()
            where T : class
        {
            context.Set<T>().Add(entity);

            if (runningCount % commitCountLimit == 0)
            {
                context.SaveChanges();
                if (recreateContext)
                {
                    context.Dispose();
                    context = new DB();
                    context.Configuration.ValidateOnSaveEnabled = false;
                    context.Configuration.AutoDetectChangesEnabled = false;
                }
            }

            return context;
        }
    }
}
