using Microsoft.AspNetCore.Mvc;
using ktwebt1234.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ktwebt1234.Controllers
{
	public class LongController : Controller
	{
		private readonly ILogger<LongController> _logger;
		private readonly QLHangHoaContext _context;

		public LongController(ILogger<LongController> logger, QLHangHoaContext context)
		{
			_logger = logger;
			_context = context;
		}

		public IActionResult Index()
		{
			var hangHoas = _context.HangHoas.Where(hh => hh.Gia >= 100).ToList();
			return View("Index", hangHoas);
		}
		public IActionResult SanPhamChiTiet(int? hid)
		{
			var hangHoas = _context.HangHoas.Where(hh => hh.MaLoai == hid).ToList();
			return PartialView("SanPhamChiTiet", hangHoas);
		}
	}
}
