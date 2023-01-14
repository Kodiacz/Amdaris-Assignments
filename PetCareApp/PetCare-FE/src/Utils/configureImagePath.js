function configureImagePath(path) {
    let index = path.indexOf(`img`);
    path = path.slice(index, path.length + 1)
    return "\\" + path
}

export { configureImagePath }