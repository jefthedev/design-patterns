![Creational - Builder](https://user-images.githubusercontent.com/60556559/153336179-680edfb4-2d3d-462d-a94e-49a190bd65f2.png)

<p>Builder pattern can be used to ease the construction of a complex object from simple objects, also separates the construction of a complex object from its representation so that the same construction process can be used to create another composition of objects.</p>

<h2>Uses</h2>
<p>Use when:</p>
<ul>
	<li>The algorithm for creating a complex object should be independent of the parts that make up the object and how they are assembled.</li>
	<li>The construction process must allow different representations for the object that is constructed.</li>
	<li>You want to insulate clients from the knowledge of the actual creation process and/or resulting product.</li>
</ul>

<h2>Pros</h2>
<ul>
	<li>Gives you control over the construction process.</li>
	<li>The build object is shielded from the details of its construction.</li>
	<li>Gives you the possibility to reuse and/or change the process and/or product independently.</li>
	<li>Code for construction is isolated from code for representation and both are easy to replace without affecting the other.</li>
</ul>
<h2>Cons</h2>
<ul>
	<li>Need flexibility in creating various complex objects.</li>
	<li>Need to create complex, aggregate objects.</li>
</ul>
<br>
<br>
<b>Source:</b> GoF