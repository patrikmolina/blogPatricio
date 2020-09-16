using blogPatricio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DbConnectionBlog.Repository
{
    
        public interface IRepository
        {

            Post GetPost(int id);
            List<Post> GetallPosts(int id);
            bool AddPost(Post post);
            bool UpdatePost(Post post);
            bool RemovePost(int id);

        }
    
}
