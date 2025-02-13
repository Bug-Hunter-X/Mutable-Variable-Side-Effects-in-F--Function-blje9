# Mutable Variable Side Effects in F# Function

This example demonstrates a common error when using mutable variables in F# functions. The `add` function modifies the input variables `x` and `y` in place which can lead to unexpected results and make debugging challenging.  The solution showcases a better approach using immutable variables to avoid such problems.