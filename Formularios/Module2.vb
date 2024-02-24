Imports System.Xml
Module Module2
    Sub cargapccadena()
        Dim DocumentoXml As XmlDocument
        Dim Nodelist As XmlNodeList
        Dim Nodo As XmlNode
        DocumentoXml = New XmlDocument
        'DocumentoXml.Load("C:\Users\Usuario\Documents\ligue.xml")
        DocumentoXml.Load("config.xml")
        Nodelist = DocumentoXml.SelectNodes("/G/Imagen")
        For Each Nodo In Nodelist
            Dim IdpC = Nodo.Attributes.GetNamedItem("Id").Value
            Pc = Nodo.ChildNodes(0).InnerText
            Cadena = Nodo.ChildNodes(1).InnerText
            BsDt = Nodo.ChildNodes(2).InnerText
            'pvr = Nodo.ChildNodes(3).InnerText
        Next
    End Sub

End Module
