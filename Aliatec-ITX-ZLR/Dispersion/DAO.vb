Imports Intelexion.Framework.Model
Imports System.Data
Imports Intelexion.Nomina
Imports System.Web
Imports System.Collections
Imports System.Collections.Specialized
Imports Intelexion.Framework.Controller
Imports Intelexion.Framework.View
Imports System.IO
Imports System.Data.SqlClient

Public Class DAO
    Inherits Intelexion.Framework.Model.DAO

    Private Const LayoutPolizaContableProvisiones As String = "sp_nomPolizaContableZELLER_Provisiones '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"
    Private Const LayoutPolizaContable As String = "sp_nomPolizaContableZELLER '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"
    Private Const LayoutPolizaContableProvisionesHist As String = "sp_nomPolizaContableZELLERhist '@IdRazonSocial','@IdTipoNominaAsig','@IdTipoNominaProc','@Anio','@Periodo','@UID','@LID','@idAccion'"

    


    Public Sub New(ByVal DataConnection As SQLDataConnection)
        MyBase.New(DataConnection)
    End Sub
    Public Function Layout(ByVal ReportesProceso As EntitiesITX.ReportesProceso, ByVal opL As String) As DataSet
        Dim ds As New DataSet
        Dim resultado As Boolean
        Dim comandstr As String
        Try
            Select Case opL

                Case "LayoutPolizaContable"
                    comandstr = LayoutPolizaContable
                    resultado = Me.ExecuteQuery(comandstr, ds, ReportesProceso)
                    Return ds

                Case "LayoutPolizaContableProvisiones"
                    comandstr = LayoutPolizaContableProvisiones
                    resultado = Me.ExecuteQuery(comandstr, ds, ReportesProceso)
                    Return ds

                Case "LayoutPolizaContableProvisionesHist"
                    comandstr = LayoutPolizaContableProvisionesHist
                    resultado = Me.ExecuteQuery(comandstr, ds, ReportesProceso)
                    Return ds



            End Select
        Catch e As Exception
        End Try
        Return ds
    End Function

    Public Function LayoutTxt(ByVal ReportesProceso As EntitiesITX.ReportesProceso, ByVal opL As String, ByVal context As System.Web.HttpContext) As String
        Dim ds As New DataSet
        Dim sFile As String
        Dim sPathApp As String = Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ApplicationPath")
        Dim sPathArchivosTemp As String = Intelexion.Framework.ApplicationConfiguration.ConfigurationSettings.GetConfigurationSettings("ArchivosTemporales")
        'Dim ruta As String
        Try
            Select Case opL
                
            End Select
        Catch e As Exception
        End Try
        Return ""
    End Function




End Class
