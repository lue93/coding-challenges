def two_fer(name=''):
    try:

        if name == '':
            name = 'you'

    except TypeError:
        raise Exception('Wrong input')
    return 'One for {}, one for me.'.format(name)