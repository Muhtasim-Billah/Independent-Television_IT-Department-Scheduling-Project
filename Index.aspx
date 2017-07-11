<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Default.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ITScheduleChecking.Models.Task>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    IT Page
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Daily Maintenance Schedule &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
        Broadcast IT &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp Date:
        <%= ViewData["CurrentDate"]%></h2>
    <form name="input" action="/IT/EditTasks" method="post">
    <table id="gradient-style" summary="List of Task">

    
     <tr id="gradient-headline">
        <td colspan="8">
        <font color=red size="14" ><center>AVID Network</center></font>
        </td>
        </tr>
        


        <tr>
            <th>
            TASK
            </th>
            <th>
                1:00 AM
            </th>
            <th>
                6:00 AM
            </th>
            <th>
                4:00 PM
            </th>
            <th>
                Checked By
            </th>
            <th>
                Supervised By
            </th>
            <th>
                comment
            </th>
            <th>
                commentedBy
            </th>
        </tr>

       

        <% for(int i = 0;i<17;i++)
           {
            %>

            
        <tr>
            <td>
                <%: Model.ElementAt(i).tName  %>
            </td>

            <td>
            <%if (Model.ElementAt(i).editAble_100AM == true)//if editable then show the task box with the value.
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).doneAt100, new { @size = "6"})%>
                
                <%}
              else //if not editable then show N/A in the text and keep a hidden text field.
              { %>
                N/A
                <%: Html.HiddenFor(model => model.ElementAt(i).doneAt100, new {@value="hidden"}) %>
                <%} %>
            </td>
            <td>
            <%if (Model.ElementAt(i).editAble_600AM == true)
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).doneAt600, new { @size = "6"})%>
                <%}
              else
              { %>
                N/A
                <%: Html.HiddenFor(model => model.ElementAt(i).doneAt600, new { @value = "hidden" })%>
                <%} %>
            </td>
 
            <td>
            <%if (Model.ElementAt(i).editAble_400PM == true)
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).doneAt400, new { @size = "6"})%>
                <%}
              else
              { %>
                N/A
                <%: Html.HiddenFor(model => model.ElementAt(i).doneAt400, new { @value = "hidden" })%>
                <%} %>
            </td>
            
            <td>
            <%if (Model.ElementAt(i).CheckedBy != null)
              { %>

                <%: Html.TextBoxFor(model => model.ElementAt(i).CheckedBy, new { @size = "6"})%>

                <%}
              else
              { %>
               
                <%: Html.HiddenFor(model => model.ElementAt(i).CheckedBy, new { @value = "hidden" })%>
                <%} %>

            </td>
           
            <td>

            <%if (Model.ElementAt(i).SupervisedBy != null)
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).SupervisedBy, new { @size = "6"})%>
                 <%}
              else
              { %>
               <%: Html.HiddenFor(model => model.ElementAt(i).SupervisedBy, new { @value = "hidden" })%>
                <%} %>

            </td>
            <td>
                
                <%: Html.TextBoxFor(model => model.ElementAt(i).comment, new{ @size = "10,20"}) %>
            </td>
            <td>
                <%: Model.ElementAt(i).commentedBy  %>
            </td>
        </tr>
        <% } %>

        <tr >
        <td colspan="8">
        <font color='olive' size="14" ><center>Inews</center></font>
        </td>
        </tr>

         <tr>
            <th>
            TASK
            </th>
            <th>
                1:00 AM
            </th>
            <th>
                6:00 AM
            </th>
            <th>
                4:00 PM
            </th>
            <th>
                Checked By
            </th>
            <th>
                Supervised By
            </th>
            <th>
                comment
            </th>
            <th>
                commentedBy
            </th>
        </tr>

         <% for(int i = 17;i<19;i++)
           {
            %>

            
        <tr>
            <td>
                <%: Model.ElementAt(i).tName  %>
            </td>

            <td>
            <%if (Model.ElementAt(i).editAble_100AM == true)//if editable then show the task box with the value.
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).doneAt100, new { @size = "6"})%>
                
                <%}
              else //if not editable then show N/A in the text and keep a hidden text field.
              { %>
                N/A
                <%: Html.HiddenFor(model => model.ElementAt(i).doneAt100, new {@value="hidden"}) %>
                <%} %>
            </td>
            <td>
            <%if (Model.ElementAt(i).editAble_600AM == true)
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).doneAt600, new { @size = "6"})%>
                <%}
              else
              { %>
                N/A
                <%: Html.HiddenFor(model => model.ElementAt(i).doneAt600, new { @value = "hidden" })%>
                <%} %>
            </td>
 
            <td>
            <%if (Model.ElementAt(i).editAble_400PM == true)
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).doneAt400, new { @size = "6"})%>
                <%}
              else
              { %>
                N/A
                <%: Html.HiddenFor(model => model.ElementAt(i).doneAt400, new { @value = "hidden" })%>
                <%} %>
            </td>
            
            <td>
            <%if (Model.ElementAt(i).CheckedBy != null)
              { %>

                <%: Html.TextBoxFor(model => model.ElementAt(i).CheckedBy, new { @size = "6"})%>

                <%}
              else
              { %>
               
                <%: Html.HiddenFor(model => model.ElementAt(i).CheckedBy, new { @value = "hidden" })%>
                <%} %>

            </td>
           
            <td>

            <%if (Model.ElementAt(i).SupervisedBy != null)
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).SupervisedBy, new { @size = "6"})%>
                 <%}
              else
              { %>
               <%: Html.HiddenFor(model => model.ElementAt(i).SupervisedBy, new { @value = "hidden" })%>
                <%} %>

            </td>
            <td>
                
                <%: Html.TextBoxFor(model => model.ElementAt(i).comment, new{ @size = "10,20"}) %>
            </td>
            <td>
                <%: Model.ElementAt(i).commentedBy  %>
            </td>
        </tr>
        <% } %>


         <tr >
        <td colspan="8">
        <font color=aqua size="14" ><center>Vizrt Network</center></font>
        </td>
        </tr>

         <tr>
            <th>
            TASK
            </th>
            <th>
                1:00 AM
            </th>
            <th>
                6:00 AM
            </th>
            <th>
                4:00 PM
            </th>
            <th>
                Checked By
            </th>
            <th>
                Supervised By
            </th>
            <th>
                comment
            </th>
            <th>
                commentedBy
            </th>
        </tr>


        <% for(int i = 19;i<24;i++)
           {
            %>

            
        <tr>
            <td>
                <%: Model.ElementAt(i).tName  %>
            </td>

            <td>
            <%if (Model.ElementAt(i).editAble_100AM == true)//if editable then show the task box with the value.
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).doneAt100, new { @size = "6"})%>
                
                <%}
              else //if not editable then show N/A in the text and keep a hidden text field.
              { %>
                N/A
                <%: Html.HiddenFor(model => model.ElementAt(i).doneAt100, new {@value="hidden"}) %>
                <%} %>
            </td>
            <td>
            <%if (Model.ElementAt(i).editAble_600AM == true)
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).doneAt600, new { @size = "6"})%>
                <%}
              else
              { %>
                N/A
                <%: Html.HiddenFor(model => model.ElementAt(i).doneAt600, new { @value = "hidden" })%>
                <%} %>
            </td>
 
            <td>
            <%if (Model.ElementAt(i).editAble_400PM == true)
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).doneAt400, new { @size = "6"})%>
                <%}
              else
              { %>
                N/A
                <%: Html.HiddenFor(model => model.ElementAt(i).doneAt400, new { @value = "hidden" })%>
                <%} %>
            </td>
            
            <td>
            <%if (Model.ElementAt(i).CheckedBy != null)
              { %>

                <%: Html.TextBoxFor(model => model.ElementAt(i).CheckedBy, new { @size = "6"})%>

                <%}
              else
              { %>
               
                <%: Html.HiddenFor(model => model.ElementAt(i).CheckedBy, new { @value = "hidden" })%>
                <%} %>

            </td>
           
            <td>

            <%if (Model.ElementAt(i).SupervisedBy != null)
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).SupervisedBy, new { @size = "6"})%>
                 <%}
              else
              { %>
               <%: Html.HiddenFor(model => model.ElementAt(i).SupervisedBy, new { @value = "hidden" })%>
                <%} %>

            </td>
            <td>
                
                <%: Html.TextBoxFor(model => model.ElementAt(i).comment, new{ @size = "10,20"}) %>
            </td>
            <td>
                <%: Model.ElementAt(i).commentedBy  %>
            </td>
        </tr>
        <% } %>


        <tr >
        <td colspan="8">
        <font color=fuchsia size="14" ><center>OMNIBUS Network<center></center></font>
        </td>
        </tr>


         <tr>
            <th>
            TASK
            </th>
            <th>
                1:00 AM
            </th>
            <th>
                6:00 AM
            </th>
            <th>
                4:00 PM
            </th>
            <th>
                Checked By
            </th>
            <th>
                Supervised By
            </th>
            <th>
                comment
            </th>
            <th>
                commentedBy
            </th>
        </tr>


        <% for(int i = 24;i<30;i++)
           {
            %>

            
        <tr>
            <td>
                <%: Model.ElementAt(i).tName  %>
            </td>

            <td>
            <%if (Model.ElementAt(i).editAble_100AM == true)//if editable then show the task box with the value.
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).doneAt100, new { @size = "6"})%>
                
                <%}
              else //if not editable then show N/A in the text and keep a hidden text field.
              { %>
                N/A
                <%: Html.HiddenFor(model => model.ElementAt(i).doneAt100, new {@value="hidden"}) %>
                <%} %>
            </td>
            <td>
            <%if (Model.ElementAt(i).editAble_600AM == true)
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).doneAt600, new { @size = "6"})%>
                <%}
              else
              { %>
                N/A
                <%: Html.HiddenFor(model => model.ElementAt(i).doneAt600, new { @value = "hidden" })%>
                <%} %>
            </td>
 
            <td>
            <%if (Model.ElementAt(i).editAble_400PM == true)
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).doneAt400, new { @size = "6"})%>
                <%}
              else
              { %>
                N/A
                <%: Html.HiddenFor(model => model.ElementAt(i).doneAt400, new { @value = "hidden" })%>
                <%} %>
            </td>
            
            <td>
            <%if (Model.ElementAt(i).CheckedBy != null)
              { %>

                <%: Html.TextBoxFor(model => model.ElementAt(i).CheckedBy, new { @size = "6"})%>

                <%}
              else
              { %>
               
                <%: Html.HiddenFor(model => model.ElementAt(i).CheckedBy, new { @value = "hidden" })%>
                <%} %>

            </td>
           
            <td>

            <%if (Model.ElementAt(i).SupervisedBy != null)
              { %>
                <%: Html.TextBoxFor(model => model.ElementAt(i).SupervisedBy, new { @size = "6"})%>
                 <%}
              else
              { %>
               <%: Html.HiddenFor(model => model.ElementAt(i).SupervisedBy, new { @value = "hidden" })%>
                <%} %>

            </td>
            <td>
                
                <%: Html.TextBoxFor(model => model.ElementAt(i).comment, new{ @size = "10,20"}) %>
            </td>
            <td>
                <%: Model.ElementAt(i).commentedBy  %>
            </td>
        </tr>
        <% } %>
    </table>
    <input type="submit" value="Save"/>
    
  

    
       
    
    </form>

     
 

   <%: Html.ActionLink("Email","SubmitMail","IT",null,new{ @class = "myLink"}) %>

  
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SideBarContentTemplate" runat="server">
</asp:Content>
