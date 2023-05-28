Imports System.Text.RegularExpressions

Module user_functions
    Function validate_email(email As String)
        Dim emailAddress = email
        Dim pattern As String = "^[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" & "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)

        If emailAddressMatch.Success Then
            validate_email = True
        Else
            validate_email = False
        End If
    End Function
End Module
