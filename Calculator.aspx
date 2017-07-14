<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="INfoEducatie.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
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
                <div style="padding:5px;" class="col-sm-2">
                    <img class="im" src="log.png"/>
                </div>
                <div style="padding:40px;" class="col-sm-8">
                    <div class="row">
                    <h1 class="text-center">Calculator</h1>
                    <br /><br />
                    <form runat="server">
                        <label>Rezultat</label><br/>
                        <asp:TextBox Width="265" class="form-control" runat="server" ID="rez" />
                        <br />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="b1" Text="1" OnClick="b1_Click" UseSubmitBehavior="False" />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="b2" Text="2" OnClick="b2_Click" UseSubmitBehavior="False" />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="b3" Text="3" OnClick="b3_Click" UseSubmitBehavior="False" />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="su" Text="+" OnClick="su_Click" UseSubmitBehavior="False" />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="di" Text="-" OnClick="di_Click" UseSubmitBehavior="False" />
                        <br />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="b4" Text="4" OnClick="b4_Click" UseSubmitBehavior="False" />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="b5" Text="5" OnClick="b5_Click" UseSubmitBehavior="False" />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="b6" Text="6" OnClick="b6_Click" UseSubmitBehavior="False" />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="pr" Text="*" UseSubmitBehavior="False" OnClick="pr_Click" />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="im" Text="/" UseSubmitBehavior="False" OnClick="im_Click" />
                        <br />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="b7" Text="7" OnClick="b7_Click" UseSubmitBehavior="False" />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="b8" Text="8" OnClick="b8_Click" UseSubmitBehavior="False" />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="b9" Text="9" OnClick="b9_Click" UseSubmitBehavior="False" />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="sq" Text="√" UseSubmitBehavior="False" OnClick="sq_Click" />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="po" Text="^" UseSubmitBehavior="False" OnClick="po_Click" />
                        <br />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="b0" Text="0" OnClick="b0_Click" UseSubmitBehavior="False" />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="zecimal" Text="." OnClick="zecimal_Click" UseSubmitBehavior="False" />
                        <asp:Button Style="width: 50px;" type="button" class="btn btn-success" runat="server" ID="minusplus" Text="+/-" OnClick="minusplus_Click" UseSubmitBehavior="False" />
                        <asp:Button Style="width: 50px;" class="btn btn-success" type="button" runat="server" ID="eq" Text="=" OnClick="eq_Click" UseSubmitBehavior="False" />

                    </form>
                </div>
                </div>
            </div>
        </div>
        <div class ="col-sm-2"></div>
    </div>
</body>
</html>
