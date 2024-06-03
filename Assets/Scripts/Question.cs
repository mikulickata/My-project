using UnityEngine;

public enum GeometricShape
{
    Cube,
    Cuboid,
    HexagonalPrism,
    SquarePyramid,
    Cone,
    Sphere,
    Cylinder,
}

public enum QuestionType
{
    SurfaceArea,
    Volume,
    DimensionCalculation
}

[System.Serializable]
public class Question
{
    public GeometricShape shape;
    public QuestionType questionType;
    public string questionText;
    public float correctAnswer;
    public float[] dimensions;
}










