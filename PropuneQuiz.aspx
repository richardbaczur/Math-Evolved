<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PropuneQuiz.aspx.cs" Inherits="INfoEducatie.PropuneQuiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    
    <title>Propune un quiz</title>
    <!-- Latest compiled and minified CSS --> 
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style>
        body {
            background-image: url("back.jpg");
        }

        .wb {
            background-color: white;
            border-radius: 10px;
        }

        .slideanim {
            visibility: hidden;
        }

        .slide {
            animation-name: slide;
            -webkit-animation-name: slide;
            animation-duration: 1s;
            -webkit-animation-duration: 1s;
            visibility: visible;
        }

        @keyframes slide {
            0% {
                opacity: 0;
                transform: translateY(70%);
            }

            100% {
                opacity: 1;
                transform: translateY(0%);
            }
        }

        @-webkit-keyframes slide {
            0% {
                opacity: 0;
                -webkit-transform: translateY(70%);
            }

            100% {
                opacity: 1;
                -webkit-transform: translateY(0%);
            }
        }

        .im {
            width: 100%;
        }
        btn{
            width:50px;
        }
        .hov:hover {
            background-color:#66ffff;
        }
        .brd{
            border-bottom-right-radius:10px;
            border-bottom-left-radius:10px;
        }
    </style>

</head>
<body>
   
    <nav class="navbar navbar-default navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navb">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="index.aspx">Math for everyone</a>
            </div>
            <div class="collapse navbar-collapse" id="navb">
                <ul class="nav navbar-nav navbar-left">
                    <li><a href="Calculator.aspx">Calculator</a></li>
                    <li><a href="Desen.aspx">Desen</a></li>
                    <li><a href="QuizSelector.aspx">Quiz</a></li>
                    <li><a href="ProblemeSel.aspx">Probleme</a></li>
                    <li><a href="Propuneri.aspx">Propuneri</a></li>
                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <li>
                        <!-- De schimbat in numele utilizatorului conectat -->
                        <a href="Profile.aspx">
                            Profile
                        </a>
                    </li>
                    <li>
                        <a href="Log In.aspx">
                            <span class="glyphicon glyphicon-log-out"></span>Log Out
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </nav><br /><br />
    <div class="row" style="padding-top:50px;padding-bottom:50px;">
        <div class="col-md-1"></div>
        <div class="col-md-10 wb">
            <div class="row">
                <div style="padding: 5px;" class="col-sm-2">
                    <img class="im" src="log.png" />
                </div>
                <div style="padding: 50px;" class="col-sm-8">
                    <div class="row">
                        <h1 runat="server" id="quiztitle" class="text-center">Propune un quiz</h1>
                        <br />
                        <br />
                        <div class="row" runat="server">
                            <form runat="server">
                               <div id="pquiz" runat="server">
                                   <label for="name">Numele quiz-ului:</label><br />
                                   <asp:TextBox runat="server" ID="name" CssClass="form-control"></asp:TextBox><br />
                                   <label for="descr">Descrierea quiz-ului:</label>
                                   <asp:TextBox runat="server" TextMode="MultiLine" Columns="50" Rows="5" CssClass="form-control" ID="descr"></asp:TextBox>
                                   <label for="e1">Enunt 1:</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="e1"></asp:TextBox><br />
                                   <label for="v1">Varianta a</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v11"></asp:TextBox><br />
                                   <label for="v2">Varianta b</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v12"></asp:TextBox><br />
                                   <label for="v3">Varianta c</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v13"></asp:TextBox><br />
                                   <label for="v4">Varianta d</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v14"></asp:TextBox><br />
                                   <label for="v5">Varianta e</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v15"></asp:TextBox><br />
                                   <label for="e2">Enunt 2:</label><br />
                                   <asp:DropDownList runat="server" CssClass="form-control" ID="vc1">
                                       <asp:ListItem Text="A" Value="A"></asp:ListItem>
                                       <asp:ListItem Text="B" Value="B"></asp:ListItem>
                                       <asp:ListItem Text="C" Value="C"></asp:ListItem>
                                       <asp:ListItem Text="D" Value="D"></asp:ListItem>
                                       <asp:ListItem Text="E" Value="E"></asp:ListItem>
                                   </asp:DropDownList><br />

                                   <asp:TextBox runat="server" CssClass="form-control" ID="e2"></asp:TextBox><br />
                                   <label for="v1">Varianta a</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v21"></asp:TextBox><br />
                                   <label for="v2">Varianta b</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v22"></asp:TextBox><br />
                                   <label for="v3">Varianta c</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v23"></asp:TextBox><br />
                                   <label for="v4">Varianta d</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v24"></asp:TextBox><br />
                                   <label for="v5">Varianta e</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v25"></asp:TextBox><br />
                                   <asp:DropDownList runat="server" CssClass="form-control" ID="vc2">
                                       <asp:ListItem Text="A" Value="A"></asp:ListItem>
                                       <asp:ListItem Text="B" Value="B"></asp:ListItem>
                                       <asp:ListItem Text="C" Value="C"></asp:ListItem>
                                       <asp:ListItem Text="D" Value="D"></asp:ListItem>
                                       <asp:ListItem Text="E" Value="E"></asp:ListItem>
                                   </asp:DropDownList><br />

                                   <label for="e3">Enunt 3:</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="e3"></asp:TextBox><br />
                                   <label for="v1">Varianta a</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v31"></asp:TextBox><br />
                                   <label for="v2">Varianta b</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v32"></asp:TextBox><br />
                                   <label for="v3">Varianta c</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v33"></asp:TextBox><br />
                                   <label for="v4">Varianta d</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v34"></asp:TextBox><br />
                                   <label for="v5">Varianta e</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v35"></asp:TextBox><br />
                                   <asp:DropDownList runat="server" CssClass="form-control" ID="vc3">
                                       <asp:ListItem Text="A" Value="A"></asp:ListItem>
                                       <asp:ListItem Text="B" Value="B"></asp:ListItem>
                                       <asp:ListItem Text="C" Value="C"></asp:ListItem>
                                       <asp:ListItem Text="D" Value="D"></asp:ListItem>
                                       <asp:ListItem Text="E" Value="E"></asp:ListItem>
                                   </asp:DropDownList><br />

                                   <label for="e4">Enunt 4:</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="e4"></asp:TextBox><br />
                                   <label for="v1">Varianta a</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v41"></asp:TextBox><br />
                                   <label for="v2">Varianta b</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v42"></asp:TextBox><br />
                                   <label for="v3">Varianta c</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v43"></asp:TextBox><br />
                                   <label for="v4">Varianta d</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v44"></asp:TextBox><br />
                                   <label for="v5">Varianta e</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v45"></asp:TextBox><br />
                                   <asp:DropDownList runat="server" CssClass="form-control" ID="vc4">
                                       <asp:ListItem Text="A" Value="A"></asp:ListItem>
                                       <asp:ListItem Text="B" Value="B"></asp:ListItem>
                                       <asp:ListItem Text="C" Value="C"></asp:ListItem>
                                       <asp:ListItem Text="D" Value="D"></asp:ListItem>
                                       <asp:ListItem Text="E" Value="E"></asp:ListItem>
                                   </asp:DropDownList><br />
                                   
                                   <label for="e5">Enunt 5:</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="e5"></asp:TextBox><br />
                                   <label for="v1">Varianta a</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v51"></asp:TextBox><br />
                                   <label for="v2">Varianta b</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v52"></asp:TextBox><br />
                                   <label for="v3">Varianta c</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v53"></asp:TextBox><br />
                                   <label for="v4">Varianta d</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v54"></asp:TextBox><br />
                                   <label for="v5">Varianta e</label><br />
                                   <asp:TextBox runat="server" CssClass="form-control" ID="v55"></asp:TextBox><br />
                                   <asp:DropDownList runat="server" CssClass="form-control" ID="vc5">
                                       <asp:ListItem Text="A" Value="A"></asp:ListItem>
                                       <asp:ListItem Text="B" Value="B"></asp:ListItem>
                                       <asp:ListItem Text="C" Value="C"></asp:ListItem>
                                       <asp:ListItem Text="D" Value="D"></asp:ListItem>
                                       <asp:ListItem Text="E" Value="E"></asp:ListItem>
                                   </asp:DropDownList><br />
                                   <asp:Button runat="server" CssClass="btn btn-primary" Text="Propune Quiz-ul" ID="trimite" OnClick="trimite_Click" />
                               </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class ="col-sm-2"></div>
    </div>

</body>
</html>
