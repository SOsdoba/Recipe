
export default function Navbar() {
    return (
        <>
            <nav className="navbar navbar-expand-lg  navbar-dark bg-dark" >
                <div className="container-fluid">
                    <a className="navbar-brand m-4 fs-4" href="/" >
                        <img src="/images/recipe.png" alt="" width="50" height="38" className="d-inline-block align-text-center pe-1" />
                        Hearty Hearth
                    </a>
                    <button className="navbar-toggler m-2" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>

                    <div className="collapse navbar-collapse" id="navbarNav">
                        <ul className="navbar-nav me-auto mb-2 mb-lg-0 m-2">
                            <li className="nav-item">
                                <a className="nav-link active" aria-current="page" href="/">Recipes</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#">Meals</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#">CookBooks</a>
                            </li>
                        </ul>
                    </div>

                </div>
            </nav>
        </>
    )
}