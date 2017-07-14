<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Desen.aspx.cs" Inherits="INfoEducatie.Desen" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <title>Desen</title>
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
        .im{
            width:100%;
        }
        .chart{
            width: 80% !important;
            max-height:700px;
            height: 70% !important;
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
    <div style="padding-top:50px; padding-bottom:50px;" class="row">
        <div class="col-md-1"></div>
        <div class="col-md-10 wb">
            <div class="row">
                <div style="padding:5px;" class="col-md-2">
                    <img class="im" src="log.png"/>
                </div>
                <div style="padding:20px;" class="col-md-10">
                    <h1 class="text-center">Desen</h1><br />
                    <form runat="server">
                        <div class="row">
                            <div class="col-md-3">
                                Variabile:<br />
                                <label for="grad">Gradul functiei:</label><br />
                                <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                    <asp:ListItem Selected="True" Text="1" Value="1" />
                                    <asp:ListItem Text="2" Value="2" />
                                    <asp:ListItem Text="3" Value="3" />
                                    <asp:ListItem Text="4" Value="4" />
                                </asp:DropDownList><br />
                                <label for="a">a</label>
                                <asp:TextBox runat="server" class="form-control" ID="a" /><br />
                                <label for="b">b</label>
                                <asp:TextBox runat="server" class="form-control" ID="b" /><br />
                                <label for="c">c</label>
                                <asp:TextBox runat="server" class="form-control" ID="c" /><br />
                                <label for="d">d</label>
                                <asp:TextBox runat="server" class="form-control" ID="d" /><br />
                                <label for="e">e</label>
                                <asp:TextBox runat="server" class="form-control" ID="e" /><br />
                                <br/>
                                <asp:Button runat="server" class="btn btn-warning" ID="plot" Text="Deseneaza" OnClick="plot_Click" />
                            </div>
                            <div class="col-md-9">
                                <div class="container-fluid">
                                    <asp:Chart ID="chart" runat="server" CssClass="text-center chart">
                                        <Series>
                                            <asp:Series Name="Series1" ChartArea="ChartArea1" ChartType="Line"></asp:Series>
                                        </Series>
                                        <ChartAreas>
                                            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                                        </ChartAreas>
                                    </asp:Chart>
                                </div>
                                <br />
                                <asp:Label runat="server" Visible="false" Text="" class="label-success"/>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
        <div class="col-md-1"></div>
    </div>
</body>
</html>