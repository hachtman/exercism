def to_rna(dna):
    source = ['G', 'C', 'T', 'A']
    dest = ['C', 'G', 'A', 'U']
    for char in list(dna):
        if char not in source:
            return ''
    return ''.join([dest[source.index(c)] if c in source else c for c in dna])
