using Hangfire;
using Microsoft.AspNetCore.Mvc;
using PostHangFire.Model;

namespace PostHangFire.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotacaoDolarController : ControllerBase
    {
       

        public CotacaoDolarController()
        {
            RecurringJob.AddOrUpdate(() => Dolar.AtualizaCotacao(0.23M), Cron.MinuteInterval(1));
        }

     
        [HttpGet(Name = "Get")]
        public string Get()
        {
            string cotacao = Dolar.Valor.ToString();
            return cotacao;
        }
    }
}
