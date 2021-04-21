Module ConnectionStringModule

    Public DataSouceString As String
    Public DatabaseString As String

    Public Function ConString() As String
        ConString = "Data Source=" + DataSouceString + ";Initial Catalog=" + DatabaseString + ";Integrated Security=True"
    End Function
End Module

'Data Source=DESKTOP-2DFFNPV;Initial Catalog=HOSTEL;Integrated Security=True
'Data Source=VEOSCRIPT;Initial Catalog=HOSTEL;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
