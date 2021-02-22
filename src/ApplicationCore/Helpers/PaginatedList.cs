using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PVAO.ApplicationCore.Helpers
{
    public class PaginatedList<T> : List<T>
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }

        public PaginatedList(List<T> items, int pageCount, int currentPage, int pageSize)
        {
            PageSize = pageSize;
            CurrentPage = currentPage;
            PageCount = pageCount;
            AddRange(items);
        }

        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int currentPage, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
            var pageCount = (int)Math.Ceiling((double)count / pageSize);

            return new PaginatedList<T>(items, pageCount, currentPage, pageSize);
        }

        public static PaginatedList<T> Create(List<T> source, int currentPage, int pageSize)
        {
            var count = source.Count;
            var receipts = source.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            return new PaginatedList<T>(receipts, count, currentPage, pageSize);
        }
    }
}
