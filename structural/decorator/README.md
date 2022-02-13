![Structural - Decorator](https://user-images.githubusercontent.com/60556559/153738389-2b39e8a2-ace4-4817-8804-dc76ea88a65a.png)

<p>Decorator lets you attach additional responsibilities and modify an instance functionality <b>dynamically</b>. It provide a flexible alternative to subclassing for extending functionality, using <b>composition</b> instead of <b>inheritance</b>.</p>

<h2>Uses</h2>
<p>Use when:</p>
<ul>
	<li>Extension by static subclassing is impractical.</li>
	<li>You want to add resposibilities to the object that you might want to change in the future.</li>
	<li>You want to add responsibilities to individual objects dynamically and transparently, without affecting the original object or other objects.</li>
</ul>

<h2>Pros</h2>
<ul>
	<li>More flexibility than static inheritance.</li>
	<li>Avoids feature-laden classes high up in the hierarchy.</li>
	<li>Enhances the object's extensibility because you make changes by coding new classes.</li>
	<li>Simplifies coding because you write a series of classes each targeted at a specific part of the functionality rather than coding all behavior into the object.</li>
</ul>
<h2>Cons</h2>
<ul>
	<li>One thing to keep in mind when implementing the Decorator pattern is that you need to keep the component interface simple. You want to avoid making the component interface overly complex, because a complex interface will make it that much harder to get each decorator right.</li>
	<li>Another potential drawback is the performance overhead associated with a long chain of decorators.</li>
</ul>
<br>
<br>
<b>Source:</b> GoF