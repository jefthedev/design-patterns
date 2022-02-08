![Structural - Adapter](https://user-images.githubusercontent.com/60556559/152667873-9a2f2c82-605f-4f41-97bd-f5248582f9a7.png)

<p>Also known as a wrapper. This pattern is used to translate the interface of one class into another interface. This way we can make classes work together that couldn't otherwise because of incompatible interfaces. Here we'll design an object adapter that relies on <b>object aggregation</b>, but the same pattern can also be implemented with <b>multiple inheritance</b> when available on your programming language.</p>

<h2>Aplicability</h2>
<p>Use when:</p>
<ul>
	<li>You does not want your code to depend directly on third parties code.</li>
	<li>You need to use a class but its interface is incompatible with the interface of your client code.</li>
	<li>You want to create a reusable class that cooperates with unrelated or unforeseen classes, that is, classes that don't necessarily have compatible interfaces.</li>
</ul>

<h2>Pros</h2>
<ul>
	<li>Highly class reusable.</li>
	<li>Also used to adapt interfaces from legacy code to new code.</li>
	<li>Popular when defining limits inside layers of an application. Even between applications.</li>
</ul>
<h2>Cons</h2>
<ul>
	<li>Increases application's complexity.</li>
</ul>
<br>
<br>
<b>Source:</b> GoF