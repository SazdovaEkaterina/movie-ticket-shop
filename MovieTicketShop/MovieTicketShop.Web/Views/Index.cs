@using Microsoft.Extensions.Options
@inject IOptions<EShop.Domain.StripeSettings> Stripe
@model EShop.Domain.DTO.CartDto

@{
ViewData["Title"] = "Index";
Layout = "~/Views/Shared/_Layout.cshtml";
}

< div class= "container" >

    < div class= "row m-4" >
 
         < table class= "table" >
  
              < thead class= "thead-dark" >
   
                   < tr >
   
                       < th scope = "col" >#</th>
                    < th scope = "col" > Item Name </ th >
     
                         < th scope = "col" > Quantity </ th >
      
                          < th scope = "col" > ItemPrice </ th >
       
                           < th ></ th >


                       </ tr >
       
                   </ thead >
       
                   < tbody >
                       @if(Model.Items.Count == 0)
                {
                    < tr >
                        < td colspan = "5" > No active Items</ td >
     
                         </ tr >
                }
                else
{
    @for(int i = 0; i < Model.Items.Count; i++)
                    {
        var item = Model.Items[i];

                        < tr >
                            < th scope = "row" >@(i + 1) </ th >


                                < td > @item.CurrnetItem.ItemName </ td >


                                < td > @item.Quantity </ td >


                                < td >$@item.CurrnetItem.ItemPrice </ td >


                                  < td >< a asp - controller = "Cart" asp - action = "DeleteFromCart" asp - route - id = "@item.ItemId" class= "btn btn-danger" > Delete From Cart</a></td>
                        </tr>
                    }
                }
            </ tbody >
            < tfoot class= "thead-dark" >


                 < tr >
 
                     < th scope = "col" > TotalPrice:</ th >
      
                          < th scope = "col" ></ th >
       
                           < th scope = "col" ></ th >
        
                            < th scope = "col" ></ th >
         
                             < th scope = "col" >$@Model.TotalPrice </ th >
             
                             </ tr >
             
                         </ tfoot >
             
                     </ table >
             
                 </ div >
             

             </ div >