using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Dynamic;

public class DynamicQuery// linq e git bana filter ve shorlarımı çalıştıracağız diyeceğimiz sınıf 
{
    public IEnumerable<Sort>? Sort { get; set; }
    public Filter? Filter { get; set; }

    public DynamicQuery()
    {
        
    }
    public DynamicQuery(IEnumerable<Sort>? sort, Filter? filter)
    {
        Filter = filter;
        Sort = sort;
    }
}
//ADONET selevt*from cars where unitprice<100 and vitestipi=otomotik Bu ADONETLİ SORGU 
//P=>P.UNİTpRİCE<=100 BUDE ENTİTİY FREMWORK İLE LNQ SORGUDUR 
