<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [Invoice.cs](./CS/Models/Invoice.cs) (VB: [Invoice.vb](./VB/Models/Invoice.vb))
* [GridViewPartial.cshtml](./CS/Views/Home/GridViewPartial.cshtml)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
<!-- default file list end -->
# Implementing a hotkey for inserting a predefined value to the specific field editor


The main idea is to handle the client-side <a href="https://documentation.devexpress.com/AspNet/DevExpressWebASPxEditorsScriptsASPxClientTextEdit_KeyDowntopic.aspx">KeyDown,</a> event, check <a href="http://www.cambiaresearch.com/articles/15/javascript-char-codes-key-codes">key code</a> (please note that the <a href="http://www.w3schools.com/jsref/dom_obj_event.asp">MouseEvent/KeyboardEvent object</a> has properties like <a href="http://www.w3schools.com/jsref/event_altkey.asp">altKey,</a> <a href="http://www.w3schools.com/jsref/event_ctrlkey.asp">ctrlKey</a> and  <a href="http://www.w3schools.com/jsref/event_shiftkey.asp">shiftKey</a>). If a user has pressed a required key combination (Shift+T in this example), <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxClassesScriptsASPxClientUtils_PreventEventAndBubbletopic">cancel the JavaScript event</a> and set a required value (the current date in this example) for an editor using the client-side <a href="https://documentation.devexpress.com/AspNet/DevExpressWebASPxEditorsScriptsASPxClientEditBase_SetValuetopic.aspx">SetValue</a> method.<br><br>To handle a column editor's KeyDown event, we use the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewGridViewEditDataColumn_PropertiesEdittopic">GridViewEditDataColumn.PropertiesEdit.</a><a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxEditorsTextBoxProperties_ClientSideEventstopic">ClientSideEvents</a> property. Please note that the PropertiesEdit value should be cast to a <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxEditorsEditPropertiesBasetopic">correct type</a> of the Properties object before you can access the ClientSideEvents collection.

<br/>


