using Demo_BooksOfShame.BLL.Models;
using Demo_BooksOfShame.DAL.Entities;

namespace Demo_BooksOfShame.BLL.Mappers
{
    internal static class BookMapper
    {
        public static BookModel ToModel(this BooksEntity entity)
        {
            return new BookModel()
            {
                Id = entity.Id,
                Title = entity.Title,
                Desc = entity.Desc,
                Status = entity.Status.Name,
                CreateDate = entity.CreateDate,
            };
        }
    }
}
