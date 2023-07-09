using System;
using UnityEngine.Perception.Randomization.Parameters;
using UnityEngine.Perception.Randomization.Samplers;

namespace UnityEngine.Perception.Randomization.Randomizers.SampleRandomizers
{
    [Serializable]
    [AddRandomizerMenu("Demo/Camera Depth Randomizer")]
public class CameraRandomizer : Randomizer
{
    public Camera camera;
    public Vector3 cameraStartPosition;
    public Vector3 cameraStartRotation;
    public Vector3 cameraRangeVector;
    public Vector3 cameraRangeVectorScale;
    public FloatParameter sampler = new FloatParameter { value = new UniformSampler(0, 1) };
    public FloatParameter sampler1 = new FloatParameter { value = new UniformSampler(-1, 1) };


    protected override void OnIterationStart()
    {
        camera.transform.position = cameraStartPosition + cameraRangeVector * sampler.Sample();
        camera.transform.rotation = Quaternion.Euler(cameraStartRotation + cameraRangeVectorScale * sampler1.Sample());
    }
}
}