' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.Diagnostics

Namespace Desktop.Analyzers
    ''' <summary>
    ''' CA2239: Provide deserialization methods for optional fields
    ''' </summary>
    <DiagnosticAnalyzer(LanguageNames.VisualBasic)>
    Public NotInheritable Class BasicProvideDeserializationMethodsForOptionalFieldsAnalyzer
        Inherits ProvideDeserializationMethodsForOptionalFieldsAnalyzer

    End Class
End Namespace