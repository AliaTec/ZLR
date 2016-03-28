Imports System.Data

Public Class Items
    Inherits DataTable

    Public Sub New()
        Me.Columns.Add("Label")
        Me.Columns.Add("Accion")
        Me.Columns.Add("Case")

        Dim newRow As DataRow

        newRow = Me.NewRow()
        newRow.Item("Label") = 100009
        'accion
        newRow.Item("Accion") = 100009
        'case del aspx
        newRow.Item("Case") = 100009
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100010
        'accion
        newRow.Item("Accion") = 100010
        'case del aspx
        newRow.Item("Case") = 100010
        Me.Rows.Add(newRow)


        newRow = Me.NewRow()
        newRow.Item("Label") = 100011
        'accion
        newRow.Item("Accion") = 100011
        'case del aspx
        newRow.Item("Case") = 100011
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100012
        'accion
        newRow.Item("Accion") = 100012
        'case del aspx
        newRow.Item("Case") = 100012
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100013
        'accion
        newRow.Item("Accion") = 100013
        'case del aspx
        newRow.Item("Case") = 100013
        Me.Rows.Add(newRow)


        newRow = Me.NewRow()
        newRow.Item("Label") = 100014
        'accion
        newRow.Item("Accion") = 100014
        'case del aspx
        newRow.Item("Case") = 100014
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100015
        'accion
        newRow.Item("Accion") = 100015
        'case del aspx
        newRow.Item("Case") = 100015
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100016
        'accion
        newRow.Item("Accion") = 100016
        'case del aspx
        newRow.Item("Case") = 100016
        Me.Rows.Add(newRow)


        newRow = Me.NewRow()
        newRow.Item("Label") = 100017
        'accion
        newRow.Item("Accion") = 100017
        'case del aspx
        newRow.Item("Case") = 100017
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100018
        'accion
        newRow.Item("Accion") = 100018
        'case del aspx
        newRow.Item("Case") = 100018
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100019
        'accion
        newRow.Item("Accion") = 100019
        'case del aspx
        newRow.Item("Case") = 100019
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100020
        'accion
        newRow.Item("Accion") = 100020
        'case del aspx
        newRow.Item("Case") = 100020
        Me.Rows.Add(newRow)

    End Sub
End Class