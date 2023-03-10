Imports NXOpen
Module NXJournal
 Sub Main () 
 Dim theSession = Session.GetSession()
Dim workPart = theSession.Parts.Work
Dim numCurves As Integer = 0
Dim curveLength As Double
For Each cur As curve In workPart.Curves
 numCurves = numCurves + 1
 curveLength = cur.GetLength
 Guide.InfoWriteLine("Curve " & numCurves & " has length " & curveLength)
Next cur
Guide.InfoWriteLine("Work part has " & numCurves & " curves.")
 End Sub
End Module
