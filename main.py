calculation_to_hours = 24
name_of_unit = "hours"
def days_to_units(num_of_days):
    if num_of_days > 0:
        return f"{num_of_days} days are {num_of_days * calculation_to_hours} {name_of_unit}"
    else:
        return "you entered a wrong value"


user_input = input("enter no of days to convert in hours \n")
user_input_number = int(user_input)

calculated_vale = days_to_units(user_input_number)
print(calculated_vale)
