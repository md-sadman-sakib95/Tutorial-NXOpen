Imports NXOpen
Module NXJournal
 Sub Main () 
 Dim theSession = Session.GetSession()	
	Dim workPart = theSession.Parts.Work
Dim p1 As New Point3d(50, -100, 0)
Dim p2 As New Point3d(50, 100, 0)
Dim line1 = workPart.Curves.CreateLine(p1, p2)
Guide.InfoWriteLine("Line created with length " & line1.GetLength)
 End Sub
End Module
