using StockMarketApi.Models;

namespace StockMarketApi.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetComments();
        Task<Comment?> GetCommentById(int id);
        Task<Comment> CreateComment(Comment commentModel);
        Task<Comment?> UpdateComment(int id, Comment commentModel);
        Task<Comment?> DeleteComment(int id);
    }
}
