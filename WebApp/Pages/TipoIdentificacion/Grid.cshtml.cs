using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.TipoIdentificacion
{
    public class GridModel : PageModel
    {
        private readonly ITIService tiService;

        public GridModel(ITIService tiService)
        {
            this.tiService = tiService;
        }

        public IEnumerable<TIEntity> GridList { get; set; } = new List<TIEntity>();

        public string Mensaje { get; set; } = "";

        public async Task<IActionResult> OnGet()
        {
            try
            {
                GridList = await tiService.Get();

                if (TempData.ContainsKey("Msg"))
                {
                    Mensaje = TempData["Msg"] as string;
                }

                TempData.Clear();

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        public async Task<IActionResult> OnGetEliminar(int id)
        {
            try
            {
                var result = await tiService.Delete(new() { IdTipoIdentificacion = id });

                if (result.CodeError!=0)
                {
                    throw new Exception(result.MsgError);
                }

                TempData["Msg"] = "Se elimin� correctamente.";

                return Redirect("Grid");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
