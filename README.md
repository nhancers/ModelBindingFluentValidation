# Model Binding Fluent Validation

##  Problem Statement
In web api there are 2 kinds of errors
1. Errors resulting from type mismatch e.g.
    1. Invalid date in datefield.
    1. string in int parameter.

These input errors result executes default Model binder validation which has the different schema than the fluent validation errors
![alt .net core formatted binding errors response](https://github.com/nhancers/ModelBindingFluentValidation/blob/master/screenshots/ModelBindingErrors.png)

2. Busines errors e.g. required field etc.

If FluentValidation is used client might be expecting errors message only in one format, however since binding errors are returned and formatted by .net framework it leads to inconsistencies between validation errors returned when datatypes cannot be mapped vs business validation (e.g. Required validation).

##  Solution
Reformat binding errors messages same format as FluentValidation error messages.

### Final Output
>   Model Binding Errors

![alt Fluent Validation formatted binding errors response](https://github.com/nhancers/ModelBindingFluentValidation/blob/master/screenshots/ModelBindingErrors_WithFluentValidationFormat.png)
 
