﻿' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports System.Composition
Imports Microsoft.CodeAnalysis.Host
Imports Microsoft.CodeAnalysis.Host.Mef
Imports Microsoft.CodeAnalysis.LanguageServices

Namespace Microsoft.CodeAnalysis.VisualBasic
    <ExportLanguageServiceFactory(GetType(ISyntaxFactsService), LanguageNames.VisualBasic), [Shared]>
    Friend Class VisualBasicSyntaxFactsServiceFactory
        Implements ILanguageServiceFactory

        Public Function CreateLanguageService(languageServices As HostLanguageServices) As ILanguageService Implements ILanguageServiceFactory.CreateLanguageService
            Return VisualBasicSyntaxFactsService.Instance
        End Function
    End Class
End Namespace
