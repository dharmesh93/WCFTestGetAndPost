<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AjaxEnabledWCFServiceApplication.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title></title>  
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $("#btnGetMulti").on("click", function () {  
            $.ajax({  
                type: "POST",  
                contentType: "application/json; charset=utf-8",  
                url: 'http://localhost/WCFService/PayMentService.svc/Multiplication',  
                data: '{"Number": "' + $("#txtgetMulti").val() + '"}',  
                processData: true,  
                dataType: "json",  
                success: function (response) {  
                      
                    alert(response.d);  
                },  
                error: function (errormsg)   
                {  
                    alert(errormsg.responseText);  
                }  
            });  
        }); 

        function fnTest() {
            debugger;
            //post

            //$.ajax({  
            //    type: "POST",  
            //    contentType: "application/json; charset=utf-8",  
            //    url: 'Service.svc/ValidateToken',  
            //    data: '{"Token": "' + $("#hdntokenValue").val() + '"}',  
            //    processData: true,  
            //    dataType: "json",  
            //    success: function (response) {  
                      
            //        alert(response.d);  
            //    },  
            //    error: function (errormsg)   
            //    {  
            //        alert(errormsg.responseText);  
            //    }  
            //});  

            //get
            //$.ajax({  
            //    type: "GET",  
            //    contentType: "application/json; charset=utf-8",  
            //    url: 'Service.svc/GetToken/' + $("#hdntokenValue").val(),  
            //    data: '',  
            //    processData: true,  
            //    dataType: "json",  
            //    success: function (response) {  
                      
            //        alert(response.d);  
            //    },  
            //    error: function (errormsg)   
            //    {  
            //        alert(errormsg.responseText);  
            //    }  
            //}); 


            //get with other
            $.ajax({  
                type: "GET",  
                contentType: "application/json; charset=utf-8",  
                url: 'http://localhost/WCFService/PayMentService.svc/ValidateToken/' + $("#hdntokenValue").val(),  
                data: '',  
                processData: true,  
                dataType: "json",  
                success: function (response) {  
                      
                    alert(response.d);  
                },  
                error: function (errormsg)   
                {  
                    alert(errormsg.responseText);  
                }  
            }); 

        }
    </script>
  
</head>  
<body bgcolor="black">  
    <form id="form1" runat="server">  
        <asp:HiddenField ID="hdntokenValue" runat="server" ClientIDMode="Static" />
    <br />      
    <br />      
    <br />    
    <table style="color: White;">  
        <tr>  
            <td>  
                Enter Number  
            </td>  
            <td>  
                <input type="text" id="txtgetMulti" />  
            </td>  
        </tr>  
        <tr>  
            <td>  
            </td>  
            <td>  
                <input id="btnGetMulti" type="button" value="Get Result" onclick="fnTest();"/>  
            </td>  
        </tr>  
    </table>  
      
    </form>  
</body>  
</html>