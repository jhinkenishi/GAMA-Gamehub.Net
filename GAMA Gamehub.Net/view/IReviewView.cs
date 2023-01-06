using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.view
{
    public delegate void LikeHandler();
    public delegate void DislikeHandler();
    public delegate void CommentHandler(string username, int productId, string message);

    public interface IReviewView : GGView
    {
        event LikeHandler OnLike;
        event DislikeHandler OnDislike;
        event CommentHandler OnComment;

    }
}
