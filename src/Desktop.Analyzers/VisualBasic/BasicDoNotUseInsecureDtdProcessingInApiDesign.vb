﻿' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.


Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.Diagnostics
Imports Microsoft.CodeAnalysis.VisualBasic

Imports Desktop.Analyzers.Common

Namespace Desktop.Analyzers
    <DiagnosticAnalyzer(LanguageNames.VisualBasic)>
    Public Class BasicDoNotUseInsecureDtdProcessingInApiDesignAnalyzer
        Inherits DoNotUseInsecureDtdProcessingInApiDesignAnalyzer
        Protected Overrides Function GetAnalyzer(context As CompilationStartAnalysisContext, types As CompilationSecurityTypes, targetFrameworkVersion As Version) As SymbolAndNodeAnalyzer
            Dim analyzer As New SymbolAndNodeAnalyzer(types, BasicSyntaxNodeHelper.DefaultInstance, targetFrameworkVersion)
            context.RegisterSyntaxNodeAction(AddressOf analyzer.AnalyzeNode, SyntaxKind.SubBlock, SyntaxKind.FunctionBlock, SyntaxKind.ConstructorBlock)

            Return analyzer
        End Function
    End Class
End Namespace

