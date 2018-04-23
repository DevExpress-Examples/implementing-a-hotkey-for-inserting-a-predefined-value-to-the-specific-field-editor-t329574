@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "GridView"
            settings.KeyFieldName = "Id"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}
            settings.SettingsEditing.AddNewRowRouteValues = New With {.Controller = "Home", .Action = "GridViewAddNewPartial"}
            settings.CommandColumn.Visible = True
            settings.CommandColumn.ShowNewButtonInHeader = True
            settings.Columns.Add( _
                Sub(column)
                        column.FieldName = "Id"
                        column.ReadOnly = True
                        column.EditFormSettings.Visible = DefaultBoolean.False
                End Sub)
            settings.Columns.Add("Description")
            settings.Columns.Add("Price")
            settings.Columns.Add(Sub(column)
                                         column.FieldName = "RegisterDate"
                                         column.ColumnType = MVCxGridViewColumnType.DateEdit
                                         CType(column.PropertiesEdit, DateEditProperties).ClientSideEvents.KeyDown = "RegisterDate_KeyDown"
                                 End Sub)
    End Sub).Bind(Model).GetHtml()