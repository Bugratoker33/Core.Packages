using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aplication.Responses;

public class GetListResponse<T>:BasePageableModel
{
    private IList<T> _items;

    public IList<T> Items
    { //eğer items varsa itemse getir yoksa Boş bir liste döndür
        get => _items??=new List<T>();
        set => _items = value;
    }
}
