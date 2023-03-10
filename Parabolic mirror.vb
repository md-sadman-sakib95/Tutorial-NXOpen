Imports NXOpen
Module NXJournal
 Sub Main () 
 Dim theSession = Session.GetSession()	
	Dim workPart = theSession.Parts.Work
Dim vertex As New Point3d(0,0,0)
Dim focus As New Point3d(100,0,0)
Dim axisX As New Vector3d(1,0,0)
Dim axisY As New Vector3d(0,1,0)
Dim focLength = focus.X
Dim h = 100.0
Dim p1, p2 As Point3d
Dim lens = workPart.Curves.CreateParabola(vertex, axisX, axisY, focLength, -h, h)
For y = -h to h Step 10.0
 Dim x = (y*y)/(4.0*focLength)
 p1 = New Point3d(x,y,0)
 p2 = New Point3d(250,y,0)
 workPart.Curves.CreateLine(focus, p1)
 workPart.Curves.CreateLine(p1, p2)
Next y
 End Sub
End Module
