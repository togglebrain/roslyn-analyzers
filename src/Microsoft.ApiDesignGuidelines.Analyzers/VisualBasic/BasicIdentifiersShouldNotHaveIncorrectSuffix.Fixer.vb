' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports System.Composition
Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.CodeFixes

Namespace Microsoft.ApiDesignGuidelines.Analyzers
    ''' <summary>
    ''' CA1711: Identifiers should not have incorrect suffix
    ''' </summary>
    <ExportCodeFixProvider(LanguageNames.VisualBasic), [Shared]>
    Public NotInheritable Class BasicIdentifiersShouldNotHaveIncorrectSuffixFixer
        Inherits IdentifiersShouldNotHaveIncorrectSuffixFixer

    End Class
End Namespace
