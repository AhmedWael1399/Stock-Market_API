using Microsoft.EntityFrameworkCore;
using StockMarketApi.Configuration;
using StockMarketApi.Interfaces;
using StockMarketApi.Models;

namespace StockMarketApi.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly StockMarketDbContext _context;
        public CommentRepository(StockMarketDbContext context)
        {
            _context = context;
        }
        public async Task<Comment> CreateComment(Comment commentModel)
        {
            await _context.AddAsync(commentModel);
            await _context.SaveChangesAsync();
            return commentModel;
        }

        public async Task<Comment?> DeleteComment(int id)
        {
            var commentModel = await _context.Comments.FirstOrDefaultAsync(c => c.Id == id);
            if (commentModel == null) 
            {
                return null;
            }
            _context.Remove(commentModel);
            await _context.SaveChangesAsync();
            return commentModel;
        }

        public async Task<Comment?> GetCommentById(int id)
        {
            var comment = await _context.Comments.Include(a => a.AppUser).FirstOrDefaultAsync(c => c.Id == id);
            if (comment == null)
            {
                return null;
            }
            return comment;
        }

        public async Task<List<Comment>> GetComments()
        {
           return await _context.Comments.Include(a => a.AppUser).ToListAsync();
        }

        public async Task<Comment?> UpdateComment(int id, Comment commentModel)
        {
            var existingComment = await _context.Comments.FirstOrDefaultAsync(c => c.Id == id);
            if (existingComment == null)
            {
                return null;
            }

            existingComment.Title = commentModel.Title;
            existingComment.Content = commentModel.Content;

            await _context.SaveChangesAsync();
            return existingComment;
        }
    }
}
