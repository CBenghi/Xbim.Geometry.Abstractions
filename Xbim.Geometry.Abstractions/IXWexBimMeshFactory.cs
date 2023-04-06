﻿namespace Xbim.Geometry.Abstractions
{
    //Todo (Ibrahim Saad): return IWexBimMesh instead of the triangulation buffer data
    public interface IXWexBimMeshFactory : IXModelScoped
    {
        byte[] CreateWexBimMesh(IXShape shape, out IXAxisAlignedBoundingBox bounds);
        byte[] CreateWexBimMesh(IXShape shape, IXMeshFactors meshFactors, double scale, out IXAxisAlignedBoundingBox bounds);
        byte[] CreateWexBimMesh(IXShape shape, out IXAxisAlignedBoundingBox bounds, out bool hasCurves);
        byte[] CreateWexBimMesh(IXShape shape, IXMeshFactors meshFactors, double scale, out IXAxisAlignedBoundingBox bounds,  out bool hasCurves);

    }
}
