using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Swaggernetcore.Controllers
{
    /// <summary>
    /// 程序员网址导航
    /// </summary>
    [Route("hrefs")]
    [Produces("application/json")]
    [ApiController]
    public class HrefsController : ControllerBase
    {
        /// <summary>
        /// 获取最近文章
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        [HttpGet("list/{top}")]
        public IEnumerable<Article> GetArticleList(int top)
        {
            List<Article> list = new List<Article>();
            Article article = new Article();
            article.Body = "Hello World!";
            article.Id = 10;
            article.Title = "I am ok!";

            list.Add(article);
            return list;
        }

        /// <summary>
        /// 保存文章
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        [HttpPost("save")]
        public ActionResult<int> Save(Article article)
        {
            var result = 0;
            return result;
        }
    }
}