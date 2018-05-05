using Let3arafo.Core;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Let3arafo.Web.Controllers
{
    public class PostController : Controller
    {
        private readonly PostRepository _postRepository;

        public PostController(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _postRepository.Get();

            return View(result);
        }
    }
}