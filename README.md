# Unity-Shaders

## Unity shader for particle effect and attempting of realistic water with shader in Unity

Video link: [Magic orb](https://www.youtube.com/watch?v=FADy5MgG3vs), [Magic orb on water](https://www.youtube.com/watch?v=6UcCZkSnGzI)


## Technology Description


### Background
In general, people use built-in shader in Unity. However we can use customized shader that is hackable and optimized for certain case of game development. 


### Details
The project contains simple shader for particle. It can be used for effects such as smoke, fire, lighting and skill effect in game development.

There are not much document or tutorial about complex shader. However they are important technoloty in game development.

Water reflection can be performed in few ways in Unity. In this project, camera target material technique is used. It is simply using material that is printed by Camera on the water surface. However Reflection with _Cube(Legacy), reflection probe is also the technique can be used for reflection in Unity. To perform realistic water i have focused on researching the displacement of vertices. I have got the idea that we can do more complicated task with C# Script outside of shader by sending values to property of shader. I could not find formulae or algorithm for creating realistic wave or water movement so they are just sin wave at the moment. But it can be improved to create water wave on the surface when object is on the surface and random water surface movement.

Transparency for realistic water is just done by changing alpha values. It could also improved when reflection is done in shader and reflection for lighting is handled well in shader.

### Variations
There are a lot of properties to create different shader for different graphic effect. But in this project only simple effects of general cases are implemented.

## Sources

Terms: Shader Programming in Unity

Explanation: [Unity Shader API](https://docs.unity3d.com/ScriptReference/Shader.html)

Tutorial: [Unity Shader Programming Live Tutorial in event](https://www.youtube.com/watch?v=3penhrrKCYg), [Unity Shader Programming Live Tutorial Series](https://www.youtube.com/watch?v=zCkC5e_Pkz4&t=4s)
