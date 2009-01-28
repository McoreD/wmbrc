Imports System.Xml

Public Class AppSettingsManager
    'class combines the appsettingsreader object function and adds a writing tool

    Dim doc As XmlDocument

    Public Shared Sub LoadAndSetValue(ByVal key As String, ByVal value As Object)
        'load xml document
        Dim document As New XmlDocument()
        document.Load(AppSettingsManager.ConfigFilename)

        'query for value
        Dim Node As XmlElement = CType(document.DocumentElement.SelectSingleNode("/configuration/appSettings/add[@key=""" & key & """]"), XmlElement)

        If Not Node Is Nothing Then
            'node or key  found so just set the value
            Node.Attributes.GetNamedItem("value").Value = value
        Else
            'node or key not found so create it
            Node = document.CreateElement("add")
            Node.SetAttribute("key", key)
            Node.SetAttribute("value", value)

            'set back to root
            Dim Root As XmlNode = document.DocumentElement.SelectSingleNode("/configuration/appSettings")

            'add node
            If Not Root Is Nothing Then
                Root.AppendChild(Node)
            Else
                Try
                    'appSettings does not exist yet so add it
                    Root = document.DocumentElement.SelectSingleNode("/configuration")
                    Root.AppendChild(document.CreateElement("appSettings"))
                    Root = document.DocumentElement.SelectSingleNode("/configuration/appSettings")
                    Root.AppendChild(Node)
                Catch ex As Exception
                    'if adding appsettings fails then throw error
                    Throw New Exception("Could not set value", ex)
                End Try
            End If
        End If

        'save results
        document.Save(AppSettingsManager.ConfigFilename)
    End Sub

    Public Shared Function LoadAndGetValue(ByVal key As String) As Object
        'load xml document
        Dim document As New XmlDocument
        document.Load(AppSettingsManager.ConfigFilename)

        'query for value
        Dim Node As XmlNode = document.DocumentElement.SelectSingleNode("/configuration/appSettings/add[@key=""" & key & """]")

        'return found value or nothing if not found
        If Not Node Is Nothing Then
            Return Node.Attributes.GetNamedItem("value").Value
        Else
            Return Nothing
        End If
    End Function

    Public Shared ReadOnly Property ConfigFilename() As String
        Get
            'return current config filename of calling app
            Return String.Concat(System.Reflection.Assembly.GetEntryAssembly.Location, ".config")
        End Get
    End Property

#Region "Non-Shared Methods"

    Public Sub SetValue(ByVal key As String, ByVal value As Object)
        'use document loaded in the constructor
        'this allows you to perform multiple set/gets without loading the document each time

        'query for value
        Dim Node As XmlElement = CType(doc.DocumentElement.SelectSingleNode("/configuration/appSettings/add[@key=""" & key & """]"), XmlElement)

        If Not Node Is Nothing Then
            'node or key  found so just set the value
            Node.Attributes.GetNamedItem("value").Value = value
        Else
            'node or key not found so create it
            Node = doc.CreateElement("add")
            Node.SetAttribute("key", key)
            Node.SetAttribute("value", value)

            'set back to root
            Dim Root As XmlNode = doc.DocumentElement.SelectSingleNode("/configuration/appSettings")

            'add node
            If Not Root Is Nothing Then
                Root.AppendChild(Node)
            Else
                Try
                    'appSettings does not exist yet so add it
                    Root = doc.DocumentElement.SelectSingleNode("/configuration")
                    Root.AppendChild(doc.CreateElement("appSettings"))
                    Root = doc.DocumentElement.SelectSingleNode("/configuration/appSettings")
                    Root.AppendChild(Node)
                Catch ex As Exception
                    'if adding appsettings fails then throw error
                    Throw New Exception("Could not set value", ex)
                End Try
            End If
        End If

        'save results
        doc.Save(AppSettingsManager.ConfigFilename)
    End Sub

    Public Function GetValue(ByVal key As String) As Object
        'use document loaded in the constructor
        'this allows you to perform multiple set/gets without loading the document each time

        'query for value
        Dim Node As XmlNode = doc.DocumentElement.SelectSingleNode("/configuration/appSettings/add[@key=""" & key & """]")

        'return found value or nothing if not found
        If Not Node Is Nothing Then
            Return Node.Attributes.GetNamedItem("value").Value
        Else
            Return Nothing
        End If
    End Function

    Public Sub New()
        doc = New XmlDocument
        doc.Load(AppSettingsManager.ConfigFilename)
    End Sub

#End Region

End Class

