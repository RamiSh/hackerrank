def handle_command(command_components):
    if components[0] == 'insert':
        numbers.insert(int(components[1]),int(components[2]))
    elif components[0] == 'print':
        print(numbers)
    elif components[0] == 'remove':
        numbers.remove(int(components[1]))
    elif components[0] == 'append':
        numbers.append(int(components[1]))
    elif components[0] == 'sort':
        numbers.sort()
    elif components[0] == 'pop':
        numbers.pop()
    elif components[0] == 'reverse':
        numbers.reverse()
if __name__ == '__main__':
    N = int(input())
    numbers = []
    for i in range(N):
        command = input()
        components = []
        if(command.__contains__(' ')):
            components = command.split(' ')
        else:
            components.insert(0,command)
        handle_command(components)

 