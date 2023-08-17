import { Col, Container, Row, Card, CardHeader, CardBody, Button } from "reactstrap"
import TablaContacto from "./Components/TablaContacto"

const App = () => {
    return (
        <Container>
            <Row className="mt-5">
                <Col sm="12">
                    <Card>
                        <CardHeader>
                            <h5>Lista de Contacto</h5>
                        </CardHeader>
                        <CardBody>
                            <Button size="sm" color="success">Nuevo Contacto</Button>
                            <hr></hr>
                            <TablaContacto/>
                        </CardBody>
                    </Card>
                </Col>
            </Row>
        </Container>
    )
}

export default App;