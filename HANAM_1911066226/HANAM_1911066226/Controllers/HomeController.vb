﻿Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function Account() As ActionResult
        ViewData("Message") = "CC."
        ViewData("Message") = "AA."
        ViewData("Message") = "BB."
        Return View()
    End Function
End Class
