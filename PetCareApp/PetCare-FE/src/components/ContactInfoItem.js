function ContactInfoItem({
    titleText,
    spanText,
    styleClassName
}) {
    return (
    <div className="col-lg-4 text-center py-2">
        <div className="d-inline-flex align-items-center">
            <i className={`bi bi-${styleClassName} fs-1 text-primary me-3`}></i>
            <div className="text-start">
                <h6 className="text-uppercase mb-1">{titleText}</h6>
                <span>{spanText}</span>
            </div>
        </div>
    </div>
)};

export default ContactInfoItem;