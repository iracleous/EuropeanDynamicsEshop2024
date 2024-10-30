using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanDynamicsEshop2024.Responses;

 public class ResponseApi<T>
{
    public int Status { get; set; }
    public string? Description { get; set; }    
    public T? Value { get; set; }
}
