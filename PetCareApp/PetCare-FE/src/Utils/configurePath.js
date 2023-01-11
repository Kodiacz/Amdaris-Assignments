function configureImagePath(path) {
    path = path.replace(`\\\\`, `\\`);
    let index = path.indexOf(`img`);
    path = path.slice(index, path.length + 1)
    return path
}

export { configureImagePath }