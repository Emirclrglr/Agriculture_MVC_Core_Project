using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents
{
	public class _TeamPartial:ViewComponent
	{
		ITeamService _teamService;

		public _TeamPartial(ITeamService teamService)
		{
			_teamService = teamService;
		}

		public IViewComponentResult Invoke()
		{
			List<Team> values = _teamService.TGetListAll();
			return View(values);
		}
	}
}
