Imports System.Web.Mvc

Namespace GridViewEditHotKeyMvc.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function GridViewPartial() As ActionResult
			Return PartialView(Invoice.GetData())
		End Function

		Public Function GridViewAddNewPartial(ByVal model As Invoice) As ActionResult
			' Update the underlying datasource here
			' ...
			Return PartialView("GridViewPartial", Invoice.GetData())
		End Function
	End Class
End Namespace
