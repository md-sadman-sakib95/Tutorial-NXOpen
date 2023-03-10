Option Explicit Off
Imports NXOpen

Public Class HelloApp
    Public Shared Sub Main()
        Dim theSession As Session = Session.GetSession()
        Dim workPart = theSession.Parts.Work
        Dim builder As Features.SphereBuilder
        builder = workPart.Features.CreateSphereBuilder(Nothing)
        ' Specify the sphere definition type (center and diameter)
        builder.Type = Features.SphereBuilder.Types.CenterPointAndDiameter
        ' Define the sphere center
        Dim center As New NXOpen.Point3d(3, 5, 6)
        Dim centerPoint As NXOpen.Point = workPart.Points.CreatePoint(center)
        builder.CenterPoint = centerPoint
        ' Define the sphere diameter
        Dim diamString As String = "1.5"
        builder.Diameter.RightHandSide = diamString
        ' Define the boolean option (create, unite, etc.)
        builder.BooleanOption.Type = NXOpen.GeometricUtilities.BooleanOperation.BooleanType.Create
        ' Commit to create the feature
        Dim sphereObject As NXOpen.Features.Sphere = builder.CommitFeature
        ' Destroy the builder to free memory
        builder.Destroy()
    End Sub
End Class

