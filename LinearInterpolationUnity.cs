// Linear Interpolation

/* It gives you a value between two vars. The easiest way to explain it
is through numbers. Later colours will explain better.*/
float result = Mathf.Lerp(3f, 5f, 0.5f);
/* Floats have an f
Mathf means you're doing math with floats
Lerp is the function for linear interpolation

Suppose you draw a line from 3f to 5f
0.5f means you're going half(50%) of the way between 3f and 5f
this will result in telling you where it is: 4f
The middle of 3 and 5 is 4

And now with Vectors*/
Vector3 from = new Vector3(1f, 2f, 3f);
Vector3 to = new Vector3(5f, 6f, 7f);

Vector3 result = Vector3.Lerp(from, to, 0.75f);
/* A vector is a 3d point. First value is the Z-axis, second value is
the Y-axis, and third is the X-axis.
To make a linear interpolation, you'll first have to define a function
for your start and end points. I recommend you use "from" and "to."
75% of the way between defined from and to Vector3(is 4, 5, 6)

The same principle is applied when using Color.Lerp. In the Color struct,
colours are represented by 4 floats representing red, blue, green, and
alpha. When using Lerp, these floats are interpolated just as with Mathf.Lerp 
and Vector3.Lerp.*/

// Linear Interpolation as a slide switch

void Update()
{
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);
}
/* If the intensity of the light starts off at 0, it'll be updated
to 4 on the first Update. Then 6, then 7, then 7.5. The rate at which
the light intensifies to 8 will slow. 
To avoid this being dependent of frame rate: */
void Update()
{
    light.intensity = Mathf.Lerp(light. intensity, 8f, 0.5f * Time.deltaTime);
}
/* This means the change to intensity would happen per second instead of per frame.*/