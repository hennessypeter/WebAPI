using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProportionValueController : ApiController
    {

        public IHttpActionResult GetProportionValue(int id)
        {
                    var list = new[] {
                    ProportionValue.Create(0.6, new Spin("",0)),
                    ProportionValue.Create(0.307, new Spin("",.7)),
                    ProportionValue.Create(0.05, new Spin("",1.4)),
                    ProportionValue.Create(0.03, new Spin("Free Spins",4.9)),
                    ProportionValue.Create(0.01, new Spin("",10.5)),
                    ProportionValue.Create(0.003, new Spin("Jackpot!",35))

                


//0.6 0
//0.307   1
//0.05    2
//0.03    7
//0.01    15
//0.003   50



                    //ProportionValue.Create(0.6, new Spin("",0)),
                    //ProportionValue.Create(0.1, new Spin("",7)),
                    //ProportionValue.Create(0.29, new Spin("",2)),
                    //ProportionValue.Create(0.009, new Spin("Free Spins",5)),
                    //ProportionValue.Create(0.001, new Spin("Jackpot!",200))
        };
            return Ok(list.ChooseByRandom());

        }
    }
}
//public IHttpActionResult GetProportionValue(int id)
//{
//    var list = new[] {
//                    ProportionValue.Create(0.6, new Spin("",0)),
//                    ProportionValue.Create(0.346, new Spin("",1)),
//                    ProportionValue.Create(0.1, new Spin("",2)),
//                     ProportionValue.Create(0.05, new Spin("Free Spins",5)),
//                    ProportionValue.Create(0.003, new Spin("",20)),
//                    ProportionValue.Create(0.001, new Spin("Jackpot!",100))
//        };