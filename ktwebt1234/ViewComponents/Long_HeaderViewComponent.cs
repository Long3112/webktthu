using ktwebt1234.Models;
using Microsoft.AspNetCore.Mvc;


namespace ktwebt1234.ViewComponents
{
	public class Long_HeaderViewComponent : ViewComponent
	{
		private readonly QLHangHoaContext _context;
		private List<LoaiHang> loaiHangs;

		public Long_HeaderViewComponent(QLHangHoaContext context)
		{
			_context = context;
			loaiHangs = _context.LoaiHangs.ToList();
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View("Long_Header", loaiHangs);
		}
	}
}
